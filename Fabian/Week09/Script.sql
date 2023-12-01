-- SELECT "Hello World!" AS Greeting;
-- select * from country;
-- select Code as Abkürzung, Name from country;
-- select Code, Name from country;
-- select * from country limit 10;
-- select * from country where Area > 1000000 and Population < 10000000;
-- select * from country where name = "Bolivia";
-- select * from country where Name like "B%S";
/*select *
from country
where name like "B%"
order by capital desc;*/

/*select c.Name Country, l.Name Language, l.Percentage
from language l
join country c on l.Country = c.Code
where l.Name = "German";*/


-- population austria
select Population from country where Code = 'A';

-- population europe
select sum(c.Population) Population
from encompasses e
inner join country c on e.Country = c.Code  
where e.Continent = "Europe" and e.Percentage >= 50;

-- rivers in austria
select * from geo_river
where geo_river.Country = 'A'
order by geo_river.River;

-- rivers in europe ebove 50%
select distinct gr.River  
from encompasses e 
join geo_river gr on e.Country = gr.Country
where Continent = 'Europe' and Percentage >= 50;

-- percentage population in europe
select (sum(Population) / (select sum(Population) 
						   from country)) * 100 PopulationPercent
from country c
join encompasses e ON e.Country = c.code
where e.Continent = 'Europe';

-- countries start with A
select * 
from country c 
where c.Name like 'A%';

-- countries start with A and sort by population
select c.Name Country, p.Name Province, p.Population
from country c 
join province p on p.Country = c.Code
where c.Name like 'A%'
order by p.Population desc;


-- sort rivers in europe by length
select distinct r.Name, r.`Length` 
from encompasses e 
join geo_river gr on e.Country = gr.Country
join river r on gr.River = r.Name 
where e.Continent = "Europe" and e.Percentage >= 50
order by r.`Length` desc;

-- islands in pacific with 50%+ muslim
select distinct gi.Island , r.Percentage 
from geo_island gi
join islandin ii on ii.Island = gi.Island 
join religion r on r.Country = gi.Country
where ii.Sea = 'Pacific Ocean'and r.Name = 'Muslim' and r.Percentage > 50;


-- all 3000s with 60%+ Roman Catholic
select distinct m.Name, m.Height, gm.Country 
from mountain m
join geo_mountain gm on m.Name = gm.Mountain
join religion r on r.Country = gm.Country 
where height >= 3000 and r.Name = 'Roman Catholic' and r.Percentage >= 60
order by height desc;

-- countries with 1+ lakes, 100m+ depth and 1+ mountains 1500+ m
select distinct c.Name 
from country c 
join geo_lake gl on c.Code = gl.Country
join lake l on gl.Lake = l.Name
join geo_mountain gm on gm.Country = c.Code 
join mountain m on m.Name = gm.Mountain
where l.`Depth` >= 100 and m.Height >= 1500;

-- population per religion
select r.Name Religion, round(sum(c.Population * r.Percentage / 100)) Population
from religion r
join country c on r.Country = c.Code
group by r.Name;

-- countries name, seas (without null values)
select distinct c.Name, gs.Sea 
from country c
join geo_sea gs on gs.Country = c.Code
order by c.Name;

-- countries name, seas (with null values)
select distinct c.Name, gs.Sea  
from country c
left join geo_sea gs on gs.Country = c.Code 
order by c.Name;

-- countries name with desert and independece date
select  distinct c.Name Country, p.Independence, gd.Desert 
from country c 
join politics p on p.Country = c.Code 
join geo_desert gd on gd.Country = c.Code 
join ethnicgroup e on e.Country = c.Code
where e.Name = 'African'
order by c.Name;

-- coutries with exact 3 cities
select c.Name, ci.Name
from(
	select country, count(*) cntCity
	from city c
	group by country
) cityCount
join country c on c.Code = cityCount.Country
join city ci on ci.country = c.Code
where cntCity = 3
order by c.Name, ci.Name;

-- 3 biggest cities in america
select c.Name Country, c2.Name City, c2.Population  
from encompasses e 
join country c on c.Code = e.Country 
join city c2 on c2.Country = c.Code
where e.Continent = 'America'
order by c2.Population desc
limit 3;

-- biggest mountain in austria
select m.Name, m.Height 
from geo_mountain gm 
join mountain m on m.Name = gm.Mountain 
where gm.Country = 'A'
order by m.Height desc
limit 1;

-- biggest mountain in europe
select e.Country, m.Name, m.Height  
from encompasses e 
join geo_mountain gm on gm.Country = e.Country 
join mountain m on m.Name = gm.Mountain 
where e.Continent = 'Europe'
order by m.Height desc
limit 1;

-- biggest mountain each continent
select e.Continent, max(m.Height) Height
from encompasses e 
join country c on c.Code = e.Country 
join geo_mountain gm on gm.Country = c.Code 
join mountain m on m.Name = gm.Mountain
group by e.Continent;


-- country with most religions
select c.Name Country, count(r.Name) Religions
from country c 
join religion r on r.Country = c.Code
group by c.Name
order by Religions desc
limit 1;

-- all organizations in austria with their member count
select o.Name Organization, count(i.`Type`) Members 
from organization o
join ismember i on i.Organization = o.Abbreviation 
join country c on c.Code = o.Country 
where c.Name  = 'Austria'
group by o.Name;

-- top 10 languages
select l.Name `Language`, round(sum(c.Population * l.Percentage / 100)) Persons
from country c 
join `language` l on l.Country = c.Code 
group by l.Name 
order by Persons desc
limit 10;


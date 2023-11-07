using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.PersonOne;

namespace Patrick.Week06.PersonThree
{
    public class CourseGroup
    {
        public string Title;
        private List<Person> _Persons;

        public CourseGroup(string title)
        {
            Title = title;
            _Persons = new List<Person>();
        }

        public void addPerson(Person p)
        {
            _Persons.Add(p);
        }

        public void addAllPerson(List<Person> list)
        {
            _Persons.AddRange(list);
        }

        public Person GetMinAge()
        {
            Person personMinAge = null;
            for(int i = 0; i < _Persons.Count; i++)
            {
                if(personMinAge == null || personMinAge.Age < _Persons[i].Age)
                {
                    personMinAge = _Persons[i];
                }
            }
            return personMinAge;
        }

        public Person GetMaxAge()
        {
            Person personMaxAge = null;
            for(int i = 0; i < _Persons.Count; i++)
            {
                if(personMaxAge == null || personMaxAge.Age > _Persons[i].Age)
                {
                    personMaxAge = _Persons[i];
                }
            }
            return personMaxAge;
        }

        public Person GetMinWeight()
        {
            Person personMinWeight = null;
            for (int i = 0; i < _Persons.Count; i++)
            {
                if(personMinWeight == null || personMinWeight.Weight > _Persons[i].Weight)
                {
                    personMinWeight = _Persons[i];
                }
            }
            return personMinWeight;
        }

        public Person GetMaxWeight()
        {
            Person personMaxWeight = null;
            for (int i = 0; i < _Persons.Count; i++)
            {
                if (personMaxWeight == null || personMaxWeight.Weight < _Persons[i].Weight)
                {
                    personMaxWeight = _Persons[i];
                }
            }
            return personMaxWeight;
        }

        public Person GetMinHeight()
        {
            Person personMinHeight = null;
            for(int i = 0; i < _Persons.Count; i++)
            {
                if(personMinHeight == null || personMinHeight.Height < _Persons[i].Height)
                {
                    personMinHeight = _Persons[i];
                }
            }
            return personMinHeight;
        }

        public Person GetMaxHeight()
        {
            Person personMaxHeight = null;
            for(int i = 0; i < _Persons.Count; i++)
            {
                if(personMaxHeight == null || personMaxHeight.Height < _Persons[i].Height)
                {
                    personMaxHeight = _Persons[i];
                }
            }
            return personMaxHeight;
        }

        public void PrintAllPersons()
        {
            foreach (Person p in _Persons)
            {
                Console.WriteLine($"{p.Name,8} {p.Age,3} {p.Height,5} {p.Weight,3} ");
            }
        }


        public void SortByAgeUp()
        {
            for (int i = 0; i < _Persons.Count; i++)
            {
                for (int j = 0; j < _Persons.Count - i - 1; j++)
                {
                    if (_Persons[j].Age > _Persons[j + 1].Age)
                    {
                        Person tempPerson = _Persons[j];
                        _Persons[j] = _Persons[j + 1];
                        _Persons[j + 1] = tempPerson;
                    }
                }
            }
        }

        public void SortByAgeDown()
        {
            for (int i = 0; i < _Persons.Count; i++)
            {
                for (int j = 0; j < _Persons.Count - i - 1; j++)
                {
                    if (_Persons[j].Age < _Persons[j + 1].Age)
                    {
                        Person tempPerson = _Persons[j];
                        _Persons[j] = _Persons[j + 1];
                        _Persons[j + 1] = tempPerson;
                    }
                }
            }
        }

        public void SortByHeightUp()
        {           
            for (int i = 0; i < _Persons.Count; i++)
            {
                for (int j = 0; j < _Persons.Count - i - 1; j++)
                {
                    if (_Persons[j].Height > _Persons[j + 1].Height)
                    {
                        Person tempPerson = _Persons[j];
                        _Persons[j] = _Persons[j + 1];
                        _Persons[j + 1] = tempPerson;
                    }
                }
            }
        }

        public void SortByHeightDown()
        {
            for (int i = 0; i < _Persons.Count; i++)
            {
                for (int j = 0; j < _Persons.Count - i - 1; j++)
                {
                    if (_Persons[j].Height < _Persons[j + 1].Height)
                    {
                        Person tempPerson = _Persons[j];
                        _Persons[j] = _Persons[j + 1];
                        _Persons[j + 1] = tempPerson;
                    }
                }
            }
        }

        public void SortByWeightUp()
        {
            for (int i = 0; i < _Persons.Count; i++)
            {
                for (int j = 0; j < _Persons.Count - i - 1; j++)
                {
                    if (_Persons[j].Weight > _Persons[j + 1].Weight)
                    {
                        Person tempPerson = _Persons[j];
                        _Persons[j] = _Persons[j + 1];
                        _Persons[j + 1] = tempPerson;
                    }
                }
            }
        }

        public void SortByWeightDown()
        {
            for (int i = 0; i < _Persons.Count; i++)
            {
                for (int j = 0; j < _Persons.Count - i - 1; j++)
                {
                    if (_Persons[j].Weight < _Persons[j + 1].Weight)
                    {
                        Person tempPerson = _Persons[j];
                        _Persons[j] = _Persons[j + 1];
                        _Persons[j + 1] = tempPerson;
                    }
                }
            }
        }
    }
}

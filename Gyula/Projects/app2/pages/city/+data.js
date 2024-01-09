
export { data }

import mysql from 'mysql2/promise';


let connection
try {
    // Create the connection to database
    connection = await mysql.createConnection({
        host: import.meta.env.DATABASE_URL,
        user: import.meta.env.DATABASE_USER,
        password: import.meta.env.DATABASE_PASSWORD,
        database: 'mondial',
    });
    console.log('DB Connect succesful')
} catch (err) {
    console.log(err);
}

async function data(pageContext) {
    console.log(pageContext)

  let results = []
  if (connection){
    try {
        [results] = await connection.execute(
            'SELECT `city`.* FROM `city` join `country` on `country`.`code`=`city`.`country` WHERE `country`.`name` = ?',
            [pageContext.routeParams.countryName]
          );
    } catch (err) {
     console.log(err);
    }
  }
//  console.log(results); // results contains rows returned by server

  return {
    results
  }
}
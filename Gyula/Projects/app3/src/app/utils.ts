import { cache } from "react";
import mysql, { FieldPacket, OkPacket, ProcedureCallPacket, ResultSetHeader, RowDataPacket } from "mysql2/promise"

let db : mysql.Connection | null = null;
async function connectToDatabase(){
    if (db == null){
        try{
            db = await mysql.createConnection({
                host: process.env.MYSQL_SERVER,
                port:3306,
                user: process.env.MYSQL_USER,
                password: process.env.MYSQL_PASSWORD,
                database: process.env.MYSQL_SCHEMA
            })
            console.log("Connect DB succesfully.")
        } catch (err){
            console.log("Database connection failed.")
            return null;
        }
    }
    return db;
}


export const getCitiesByCountry = cache(async (country: string) => {
    let db = await connectToDatabase()
    let result: OkPacket | RowDataPacket[] | FieldPacket[] | ResultSetHeader[] | RowDataPacket[][] | OkPacket[] | ProcedureCallPacket = []
    if (db){
        [result] = await (await db).execute(
        'SELECT `city`.* FROM `city` join `country` on `country`.`code`=`city`.`country` WHERE `country`.`name` = ?',
        [country])
    }
    return (result as RowDataPacket[])
})
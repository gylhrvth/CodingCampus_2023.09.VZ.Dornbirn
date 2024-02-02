import { Injectable } from '@angular/core';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class RandomUserService {

  constructor() { }

  async getRandomUser(): Promise<User> {

    let restApiAnswer = await fetch('https://randomuser.me/api');
    let randomUser = await restApiAnswer.json();

    let userReceived = randomUser.results[0];

    return new Promise((resolve, reject)=> resolve({
      gender: userReceived.gender,
      name: userReceived.name,
      email: userReceived.email,
      cell: userReceived.cell,
      picture: userReceived.picture
    }));    

/*
    return new Promise((resolve, reject)=> resolve({
      gender: "male",
      name: {
        title: "Mr.",
        first: "Fred",
        last: "Franko"
      },
      email: "xyz@abc.de",
      cell: "+453 44556 66754",
      picture: {
        medium: "fdfdf",
        large: "fdfdfd",
        thumbnail: "fdffff"
      }
    }));
*/
  }
}

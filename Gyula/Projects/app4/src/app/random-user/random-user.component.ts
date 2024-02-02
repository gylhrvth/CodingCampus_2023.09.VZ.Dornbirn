import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { User } from '../user';
import { RandomUserService } from '../random-user.service';

@Component({
  selector: 'app-random-user',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  template: `
    <div class="randomUser">
      <div class="image">
        <img [src]="currentUser?.picture?.medium" alt="">
      </div>
      <div class="name">{{currentUser?.name?.first}} {{currentUser?.name?.last}}</div>
      <div class="email">{{currentUser?.email}}</div>
      <div class="cell">{{currentUser?.cell}}</div>
    </div>
  `,
  styleUrl: './random-user.component.css'
})
export class RandomUserComponent {
  currentUser: User | undefined = undefined;
  randomUserService: RandomUserService = inject(RandomUserService);

  constructor(){
    this.randomUserService.getRandomUser().then(
        (value) => this.currentUser = value
    );
  }
}

import { Component } from '@angular/core';
import { RandomUserComponent } from '../random-user/random-user.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RandomUserComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  title: string = "";
}

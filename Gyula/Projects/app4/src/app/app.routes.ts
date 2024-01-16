import { Routes } from '@angular/router';
import { RandomUserComponent } from './random-user/random-user.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    {
        path: '',
        component: HomeComponent,
        title: 'Home page'
      },
      {
        path: 'user',
        component: RandomUserComponent,
        title: 'Random User'
      },

];

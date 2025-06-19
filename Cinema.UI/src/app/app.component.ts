import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListMovieComponent } from './admin/list-movie/list-movie.component';
import { AddMovieComponent } from './admin/add-movie/add-movie.component';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ListMovieComponent, AddMovieComponent, CommonModule ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Cinema.UI';
 
}

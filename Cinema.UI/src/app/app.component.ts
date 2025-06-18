import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListMovieComponent } from "./list-movie/list-movie.component";
import { AddMovieComponent } from "./add-movie/add-movie.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ListMovieComponent, AddMovieComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Cinema.UI';
}

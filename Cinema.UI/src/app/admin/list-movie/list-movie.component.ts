import { Component } from '@angular/core';

@Component({
  selector: 'app-list-movie',
  standalone: true,
  imports: [],
  templateUrl: './list-movie.component.html',
  styleUrl: './list-movie.component.css'
})

export class ListMovieComponent {
  numbers = Array(5).fill(0).map((_, i) => i + 1);
   
}

import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AddMovieComponent } from '../add-movie/add-movie.component';


@Component({
  selector: 'app-list-movie',
  standalone: true,
  imports: [CommonModule, AddMovieComponent],
  templateUrl: './list-movie.component.html',
  styleUrl: './list-movie.component.css'
})

export class ListMovieComponent {
  numbers = Array(5).fill(0).map((_, i) => i + 1);
   
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Movie } from '../app/models/movie';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  private url = "movie"
  constructor(private http:HttpClient) {

   }
   public getAllMovie():Observable<Movie[]> {
      return this.http.get<Movie[]>(`${environment.apiUrl}/${this.url}`)
   }
   public createMovie(movie : Movie) : Observable<Movie[]>{
     return this.http.post<Movie[]>(`${environment.apiUrl}/${this.url}`,movie)
   } 
}

import { Routes } from '@angular/router';
import { ListMovieComponent } from './admin/list-movie/list-movie.component';

export const routes: Routes = [
    {
        path: 'movieList', title: 'Danh sách phim', component: ListMovieComponent
    },
];

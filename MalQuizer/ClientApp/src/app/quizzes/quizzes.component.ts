import { Component, Inject} from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-quizzes',
  templateUrl: './quizzes.component.html',
  styleUrls: ['./quizzes.component.css']
})
export class QuizzesComponent
{
  public quizzes: quiz[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  {
    http.get<quiz[]>(baseUrl + 'quizzes').subscribe(result => {
      this.quizzes = result;
    }, error => console.error(error));
  }
}

interface quiz {
  id: number;
  name: string;
  category: string;
}


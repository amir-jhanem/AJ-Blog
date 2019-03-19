import { NotifyModel } from './notify-model';
import { Component, OnInit } from '@angular/core';
import { NotifyService } from './services/Notifyservice';
import { HttpClient } from '@angular/common/http';
 
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';
  public NotifyModel: NotifyModel[];

  constructor(public notifyService: NotifyService, private http: HttpClient) { }
 
  ngOnInit() {
    this.notifyService.startConnection();
    this.notifyService.addTransferBlogDataListener();   
    this.startHttpRequest();
  }
 
  private startHttpRequest = () => {
    this.http.get<NotifyModel[]>('https://localhost:5001/api/post')
      .subscribe(res => {
         console.log(res);
         this.NotifyModel = res;
      })
  }
}
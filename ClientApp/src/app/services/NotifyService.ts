import { Injectable } from '@angular/core';
import * as signalR from "@aspnet/signalr";
import { NotifyModel } from '../notify-model';
 
@Injectable({
  providedIn: 'root'
})
export class NotifyService {
  public data: NotifyModel[];
 
private hubConnection: signalR.HubConnection
 
  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
                            .withUrl('https://localhost:5001/notify')
                            .build();
 
    this.hubConnection
      .start()
      .then(() => console.log('Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err))
  }
 
  public addTransferBlogDataListener = () => {
    this.hubConnection.on('transferblogdata', (data) => {
      this.data = data;
      console.log(data);
    });
  }
}
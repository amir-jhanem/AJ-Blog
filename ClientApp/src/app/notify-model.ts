export interface NotifyModel {
    data: [
        {
            Id:number,
            Title:string,
            Subtitle:string,
            ImageUrl:string,
            Body:string,
            CreationDate:Date,
            AuthorId:number,
            Author:{
                Id:number,
                Name:string
            }
        }
    ],
    label: string
}

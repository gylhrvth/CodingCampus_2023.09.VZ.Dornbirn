export interface User {
    gender: string;
    name: Name;
    email: string;
    cell: string;
    picture: Picture;
  }
  
  interface Name {
    title: string;
    first: string;
    last: string;
  }
  
  interface Picture{
    large: string;
    medium: string;
    thumbnail: string;
  }
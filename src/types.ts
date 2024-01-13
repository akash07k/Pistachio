export interface Note {
  id: number;
  title: string;
  content: string;
  description: string;
  tags: string[];
  createdAt: Date;
  updatedAt: Date;
}

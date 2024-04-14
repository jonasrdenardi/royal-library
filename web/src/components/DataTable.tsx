import React from 'react';

interface Book {
  title: string;
  publisher: string;
  author: string;
  type: string;
  isbn: string;
  category: string;
  availableCopies: string;
}

interface DataTableProps {
  data: Book[];
}

const DataTable: React.FC<DataTableProps> = ({ data }) => {
  return (
    <table>
      <thead>
        <tr>
          <th>Book Title</th>
          <th>Publisher</th>
          <th>Author</th>
          <th>Type</th>
          <th>ISBN</th>
          <th>Category</th>
          <th>Available Copies</th>
        </tr>
      </thead>
      <tbody>
        {data.map((book, index) => (
          <tr key={index}>
            <td>{book.title}</td>
            <td>{book.publisher}</td>
            <td>{book.author}</td>
            <td>{book.type}</td>
            <td>{book.isbn}</td>
            <td>{book.category}</td>
            <td>{book.availableCopies}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default DataTable;

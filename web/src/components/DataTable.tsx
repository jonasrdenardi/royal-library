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
    <table style={{ borderCollapse: 'collapse', width: '100%' }}>
      <thead>
        <tr style={{ borderBottom: '1px solid #ddd' }}>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>Book Title</th>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>Publisher</th>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>Author</th>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>Type</th>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>ISBN</th>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>Category</th>
          <th style={{ border: '1px solid #ddd', padding: '8px' }}>Available Copies</th>
        </tr>
      </thead>
      <tbody>
        {data.map((book, index) => (
          <tr key={index} style={{ borderBottom: '1px solid #ddd' }}>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.title}</td>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.publisher}</td>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.author}</td>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.type}</td>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.isbn}</td>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.category}</td>
            <td style={{ border: '1px solid #ddd', padding: '8px', whiteSpace: 'nowrap' }}>{book.availableCopies}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default DataTable;

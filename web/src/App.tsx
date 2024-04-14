import React, { useState } from 'react';
import SearchForm from './components/SearchForm';
import DataTable from './components/DataTable';

const App: React.FC = () => {
  const [searchResults, setSearchResults] = useState<any[]>([]);

  const handleSearch = async (searchBy: string, searchValue: string) => {
    try {
      const response = await fetch(`https://localhost:5001/books?SearchBookBy=${searchBy}&SearchBookValue=${searchValue}`);
      if (!response.ok) {
        throw new Error('Erro ao buscar dados');
      }
      const data = await response.json();
      setSearchResults(data.books);
    } catch (error) {
      console.error('Erro:', error);
    }
  };

  return (
    <div>
      <h1>Search App</h1>
      <SearchForm onSearch={handleSearch} />
      <DataTable data={searchResults} />
    </div>
  );
};

export default App;

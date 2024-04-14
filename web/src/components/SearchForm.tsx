import React, { useState } from 'react';

interface SearchFormProps {
  onSearch: (searchBy: string, searchValue: string) => void;
}

const SearchForm: React.FC<SearchFormProps> = ({ onSearch }) => {
  const [searchBy, setSearchBy] = useState('');
  const [searchValue, setSearchValue] = useState('');

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onSearch(searchBy, searchValue);
  };

  return (
    <form onSubmit={handleSubmit}>
      <input type="text" value={searchBy} onChange={(e) => setSearchBy(e.target.value)} />
      <input type="text" value={searchValue} onChange={(e) => setSearchValue(e.target.value)} />
      <button type="submit">Search</button>
    </form>
  );
};

export default SearchForm;

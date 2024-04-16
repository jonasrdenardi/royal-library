import React, { useState } from 'react';
import { FormControl, InputLabel, Select, MenuItem, TextField, Button } from '@mui/material'; // Importando componentes do Material-UI

enum SearchBook {
  Title = 1,
  Author = 2,
  Type = 3,
  ISBN = 4,
  Category = 5
}

interface SearchFormProps {
  onSearch: (searchBy: SearchBook, searchValue: string) => void;
}

const SearchForm: React.FC<SearchFormProps> = ({ onSearch }) => {
  const [searchBy, setSearchBy] = useState(SearchBook.Title);
  const [searchValue, setSearchValue] = useState('');

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onSearch(searchBy, searchValue);
  };

  return (
    <form onSubmit={handleSubmit} style={{ marginBottom: '20px' }}>
      <FormControl style={{ marginRight: '10px' }}>
        <InputLabel id="search-by-label">Search By</InputLabel>
        <Select
          labelId="search-by-label"
          value={searchBy}
          onChange={(e) => setSearchBy(parseInt(e.target.value as string))}
        >
          {Object.values(SearchBook).map((value) => (
            <MenuItem key={value} value={value}>{SearchBook[value as keyof typeof SearchBook]}</MenuItem>
          ))}
        </Select>
      </FormControl>
      <TextField
        label="Search Value"
        value={searchValue}
        onChange={(e: React.ChangeEvent<HTMLInputElement>) => setSearchValue(e.target.value)}
        style={{ marginRight: '10px' }}
      />

      <Button variant="contained" color="primary" type="submit">Search</Button>
    </form>
  );
};

export default SearchForm;

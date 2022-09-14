import './App.css';
import Catalog from '../../features/catalog/Catalog';
import Header from './Header';
import { createTheme, CssBaseline, ThemeProvider } from '@mui/material';
import { Container } from '@mui/system';
import { useState } from 'react';



function App() {
  const [darkMode,setDarkMode] = useState(true);
  const paletteType = darkMode ? 'light':'dark';
  const theme = createTheme({
    palette:{
      mode:paletteType,
      background:{
        default: paletteType === 'light'? '#eaeaeaea' : '#121212'
      }
    }
  })

  function handleThemeChange(){
    setDarkMode(!darkMode)
  }

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Header darkMode={darkMode} handleThemeChange={handleThemeChange} />
      <Container >
        <Catalog/>
      </Container>
    </ThemeProvider>
  );
}

export default App;

import { Provider as PaperProvider, DefaultTheme } from 'react-native-paper';
import Home from './pages/Home';
import Navbar from './components/Navbar';

const theme = {
  ...DefaultTheme,
  colors: {
    ...DefaultTheme.colors,
    primary: '#6200ee', // Your primary color
    accent: '#03dac4',  // Your accent color
  },
};


const App = () => {
  return (
    <PaperProvider theme={theme}>
      <Navbar />
      <Home />
    </PaperProvider>
  );
}

export default App
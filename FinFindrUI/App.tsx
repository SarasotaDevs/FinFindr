import React from 'react';
import { Provider as PaperProvider, DefaultTheme } from 'react-native-paper';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import Home from './pages/Home/Home';
import Wallet from './pages/Wallet/Wallet';
import Navbar from './components/Navbar';
import { useWindowDimensions } from 'react-native';
import Footer from './components/Footer';
import {Auth0Provider} from 'react-native-auth0';
import authCredentials from './auth/Auth0';
import { UserAuthProvider } from './context/UserAuth';
import Profile from './pages/Profile/Profile';

const theme = {
  ...DefaultTheme,
  colors: {
    ...DefaultTheme.colors,
    primary: '#6200ee', // Your primary color
    accent: '#03dac4',  // Your accent color
  },
};

// Create Stack Navigator
const Stack = createNativeStackNavigator();



const App = () => {

  const { width } = useWindowDimensions();
  const isMobile = width < 600; // Adjust breakpoint as needed

  return (
    <Auth0Provider domain={authCredentials.domain} clientId={authCredentials.clientId}>
     <UserAuthProvider>
          <NavigationContainer>
          <PaperProvider theme={theme}>
            {!isMobile && <Navbar />}
          <Stack.Navigator initialRouteName="Home">
              <Stack.Screen name="Home" component={Home} options={{ headerShown: false }}/>
              <Stack.Screen name="Wallet" component={Wallet}options={{ headerShown: false }}/>
              <Stack.Screen name="Profile" component={Profile}options={{ headerShown: false }}/>


            </Stack.Navigator>
          {isMobile && <Footer />}
          </PaperProvider>
        </NavigationContainer>
      </UserAuthProvider>
    </Auth0Provider>
   
  );
}

export default App;

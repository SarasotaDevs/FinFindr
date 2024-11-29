import React from 'react';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import Home from '../pages/Home/Home';
import Portfolio from '../pages/Portfolio/Portfolio';
import { NavigationContainer } from '@react-navigation/native';
const Tab = createBottomTabNavigator();

export default function Layout() {
  return (
      <NavigationContainer>
        <Tab.Navigator>
          <Tab.Screen name="Home" component={Home} />
          <Tab.Screen name="Portfolio" component={Portfolio} />
        </Tab.Navigator>
      </NavigationContainer>
  );
}


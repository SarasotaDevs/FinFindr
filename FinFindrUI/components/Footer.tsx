// components/Footer.js
import React from 'react';
import { StyleSheet } from 'react-native';
import { Appbar } from 'react-native-paper';
import { useNavigation } from '@react-navigation/native';
import { StackNavigationProp } from '@react-navigation/stack';

const Footer = () => {
  
  const navigation = useNavigation();

  return (
    <Appbar style={styles.footer}>
      <Appbar.Action
        icon="home"
        color="white"  // Set the icon color to white
        accessibilityLabel="Home"
        onPress={() => navigation.navigate('Home')}
      />
      <Appbar.Action 
        color="white"
        icon="wallet"
        onPress={() => navigation.navigate('Wallet')}
        />
      <Appbar.Action
        icon="account"
        color="white"  // Set the icon color to white
        accessibilityLabel="Profile"
        onPress={() => navigation.navigate('Profile')}
      />
    </Appbar>
  );
};

const styles = StyleSheet.create({
  footer: {
    position: 'absolute',
    left: 0,
    right: 0,
    bottom: 0,
    height: 56,
    backgroundColor: '#000000', // Footer background color
    justifyContent: 'space-around',
  },
});

export default Footer;

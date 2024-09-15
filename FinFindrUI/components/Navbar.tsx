import { useNavigation } from '@react-navigation/native';
import React from 'react';
import { Pressable, Text, View, StyleSheet } from 'react-native';
import { Appbar } from 'react-native-paper';
import { styles } from './styles/NavbarStyles';
import { useAuth } from '../hooks/useAuth';


const Navbar = () => {

  const {login} = useAuth()

    const navigation = useNavigation();

  return (
    <Appbar.Header>
      <Pressable onPress={() => navigation.navigate('Home')}>
        <Text style={styles.title}>FinFindr</Text>
      </Pressable>

      {/* Container for Login and Sign Up */}
      <View style={styles.rightContainer}>
      <Pressable onPress={() => navigation.navigate('Home')}>
          <Text style={styles.navText}>Home</Text>
        </Pressable>
        <Pressable onPress={() => navigation.navigate('Wallet')}>
          <Text style={styles.navText}>Wallet</Text>
        </Pressable>
        <Pressable onPress={() => login()}>
          <Text style={styles.navText}>Login</Text>
        </Pressable>
        <Pressable onPress={() => login()}>
          <Text style={styles.navText}>Sign Up</Text>
        </Pressable>
      <Pressable onPress={() => login()}>
        <Text style={styles.navText}>Logout</Text>
      </Pressable>
      </View>
    </Appbar.Header>
  );
};

export default Navbar;

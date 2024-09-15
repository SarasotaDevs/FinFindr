import React, { useContext } from 'react';
import { View, StyleSheet, ScrollView, Pressable } from 'react-native';
import { Appbar, Card, Button, Text } from 'react-native-paper';
import WalletCard from './WalletCard';
import { UserAuth } from '../../context/UserAuth';
import { useNavigation } from '@react-navigation/native';
import { userExists } from '../../helpers/UserAuthHelpers';
import SideCards from './SideCards';

const Home = () => {
  const { userName } = useContext(UserAuth);
  console.log(userName)

  const navigation = useNavigation();
  
  return (
    <ScrollView contentContainerStyle={styles.viewBackgroundContainer}>

    <View style={styles.cardContainer}>
      <WalletCard/>
      <SideCards/>
    </View>
  </ScrollView>
  )
};

export default Home;



const styles = StyleSheet.create({
  viewBackgroundContainer: {
    display: "flex",
    alignItems: 'center',
    flexDirection: "column",
    paddingBottom: 64
  },
  cardContainer: {
    display: "flex",
    alignItems: "center",
    width: "90%",
    height: "100%",
    marginTop: 32,
  },
  line: {
    backgroundColor: "#0A74DA",
    height: 1,
    alignSelf: "center",
    marginTop: 8,
    marginBottom: 8,
    width: "100%"
  },
});

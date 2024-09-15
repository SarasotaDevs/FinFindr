import React, { useContext } from 'react';
import { View, StyleSheet, ScrollView, Pressable } from 'react-native';
import { Appbar, Card, Button, Text } from 'react-native-paper';
import WalletCard from './WalletCard';
import { UserAuth } from '../../context/UserAuth';
import { useNavigation } from '@react-navigation/native';
import { userExists } from '../../helpers/UserAuthHelpers';
import { sideCards, styles } from './styles';
const SideCards = () => {

    const { userName } = useContext(UserAuth);
    console.log(userName)
  
    const navigation = useNavigation();

  return (
    <View style={sideCards.container}>
    <Card style={sideCards.sideCard}>
    <View style={sideCards.sideCardHeader}>
      <Text style={sideCards.sideCardHeaderText}>Most Frequently Card</Text>
      <View style={styles.line} />
      <View  style={sideCards.sideCardContentContainer}>
      {userExists(userName) ? (
          <Text style={sideCards.sideCardContentTextHeader}>
            Capital One Savior One Card
          </Text>
      ) : (
    
         <Pressable style={sideCards.loginButton} onPress={() => navigation.navigate('Login')}>
         <Text style={{ fontSize: 20, color: 'white' }}>Login To View</Text>
       </Pressable>
      )}
      </View>
    </View>
  </Card>


  <Card style={sideCards.sideCard}>
    <View style={sideCards.sideCardHeader}>
      <Text style={sideCards.sideCardHeaderText}>Common Vendor</Text>
      <View style={styles.line} />
      <View  style={sideCards.sideCardContentContainer}>
      {userExists(userName) ? (
        <Text style={sideCards.sideCardContentTextHeader}>
        Resturant
      </Text>
      ) : (
      <Pressable style={sideCards.loginButton} onPress={() => navigation.navigate('Login')}>
        <Text style={{ fontSize: 20, color: 'white' }}>Login To View</Text>
      </Pressable>
      )}
      </View>
    </View>
  </Card>
  </View>
  )
}

  

export default SideCards
import React, { useState } from 'react'
import { View, StyleSheet, Pressable } from 'react-native';
import { Card,  Text } from 'react-native-paper'
import homeJSON from '../wallet.json'
import { useNavigation } from '@react-navigation/native';
import useAccordion from '../../hooks/useAccordian';
import {walletCard, styles} from './styles'
const WalletCard = () => {
    const navigation = useNavigation();

    const [expanded, handlePress] = useAccordion(0)


  return (
    <Card style={walletCard.walletCard}>
        <View style={walletCard.walletCardHeader}>
          <Text style={walletCard.walletCardHeaderText}>Wallet</Text>
          <View style={styles.line} />
          {homeJSON.cards.length === 1 ? (
              <View style={walletCard.walletCardContentContainer}>
                  <Text style={walletCard.walletCardContentTextHeader}>
                      {homeJSON.cards[0].name}
                  </Text>
                  <View>
                      {homeJSON.cards[0].benefits.map((benefit: any, benefitIndex: any) => (
                          <Text key={benefitIndex} style={walletCard.walletCardContentText}>
                              {benefit}
                          </Text>
                      ))}
                  </View>
              </View>
          ) : (
              homeJSON.cards.map((item: any, index: any) => (
                  <Pressable key={index} style={walletCard.walletCardContentContainer} onPress={() => handlePress(index)}>
                      <Text style={expanded === index ? walletCard.walletCardContentTextHeaderSelected : walletCard.walletCardContentTextHeader}>
                          {item.name}
                      </Text>
                      {expanded === index && (
                          <View>
                              {item.benefits.map((benefit: any, benefitIndex: any) => (
                                  <Text key={benefitIndex} style={walletCard.walletCardContentText}>
                                      {benefit}
                                  </Text>
                              ))}
                          </View>
                      )}
                  </Pressable>
              ))
          )}
          {homeJSON.cards.length === 0 && (
              <Pressable style={walletCard.addCardButton} onPress={() => navigation.navigate('Wallet')}>
                  Add Card +
              </Pressable>
          )}
        </View>

        
      </Card>
  )

  
}
  

export default WalletCard
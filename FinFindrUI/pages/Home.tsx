import React from 'react';
import { View, StyleSheet } from 'react-native';
import { Appbar, Card, Button, Text } from 'react-native-paper';

const Home = () => {
  return (
    <View style={styles.container}>
            Hello World
    </View>
  );
};

export default Home;

const styles = StyleSheet.create({
  container: {
    flex: 1,
  }
});

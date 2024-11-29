import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { styles } from './style';
import { test } from '../../api/user/CreateUser';
import { Button } from 'react-native';

export default function Portfolio() {

  return (
    <View style={styles.container}>
      <Text style={styles.title}>My Portfolio</Text>
      <Text style={styles.description}>
        Welcome to my portfolio page. Here you can find my projects and achievements.
      </Text>
      <Button title="Test" onPress={test} />
    </View>
  );
}
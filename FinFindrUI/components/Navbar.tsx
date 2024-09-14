import React from 'react';
import { TouchableOpacity, Text } from 'react-native';
import { Appbar } from 'react-native-paper';


const Navbar = () => {
    return (
      <Appbar.Header>
        <Appbar.Content title="FinFindr"/>
        <TouchableOpacity onPress={() => {/* */}}>
          <Text style={{ marginLeft: "auto", marginRight: 16 }}>Login</Text>
        </TouchableOpacity>
        <TouchableOpacity onPress={() => { /* Navigation or action logic */ }}>
          <Text style={{ marginLeft: "auto", marginRight: 16 }}>Sign Up</Text>
        </TouchableOpacity>

      </Appbar.Header>
    );
  };
  
  export default Navbar;
  
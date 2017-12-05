import React from 'react';
import { Button, StyleSheet, Text, View } from 'react-native';

import {FormLabel, FormInput} from 'react-native-elements';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  welcome: {
    fontSize: 20,
    textAlign: 'center',
    margin: 10,
  },
});

class LoginScreen extends React.Component {
  state = {
    userName: '',
    password: ''
  }
  
  updateUserName = (userName) => {
    this.setState({userName});
  }

  updatePassword = (password) => {
    this.setState({password});
  }

  render() {
    return(
    <View style={styles.container}>
      <FormLabel>User name</FormLabel>
      <FormInput onChangeText={(text)=>this.updateUserName(text)} value={this.state.userName}/>
      <FormLabel>password</FormLabel>
      <FormInput onChangeText={(text)=>this.updatePassword(text)} value={this.state.password} secureTextEntry={true}/>
  
      <Button
        onPress={() => this.props.navigation.dispatch({ type: 'Login', params: { userName: this.state.userName, password: this.state.password}} )}
        title="Log in"
      />
    </View>);
  }
};


LoginScreen.navigationOptions = {
  title: 'Log In',
};

export default LoginScreen;
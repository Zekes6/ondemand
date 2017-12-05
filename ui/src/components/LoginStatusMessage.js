import React from 'react';
import { connect } from 'react-redux';
import { Button, StyleSheet, Text, View } from 'react-native';
import { NavigationActions } from 'react-navigation';
import ListOfInsurances from './ListOfInsurances';

const styles = StyleSheet.create({
  welcome: {
    fontSize: 20,
    textAlign: 'center',
    margin: 10,
  },
});

const LoginStatusMessage = ({isLoggedIn}) => {
  if (!isLoggedIn) {
    return <Text>Please log in</Text>;
  }
  return (
    <ListOfInsurances />
  );
};

const mapStateToProps = state => ({
  isLoggedIn: state.auth.isLoggedIn,
});

export default connect(mapStateToProps)(LoginStatusMessage);
import React from 'react';
import { connect } from 'react-redux';
import { Button, StyleSheet, Text, View } from 'react-native';
import { NavigationActions } from 'react-navigation';
import {List, ListItem} from 'react-native-elements';

const ListOfInsurances = ({list}) => {
  return (
    <View>
        <Text>List of insurances:</Text>
        <List>
            {list.map((l, i) => (
            <ListItem
                key={i}
                title={l.name}
            />
            ))}
      </List>
    </View>
  );
};

const mapStateToProps = state => ({
  list: state.insurances.list,
});

const mapDispatchToProps = dispatch => {
    return {

    }
}

export default connect(mapStateToProps,mapDispatchToProps)(ListOfInsurances);
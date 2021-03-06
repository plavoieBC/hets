import React from 'react';

import { Grid, Row, Col } from 'react-bootstrap';
import { Form, FormGroup, HelpBlock, ControlLabel } from 'react-bootstrap';

import _ from 'lodash';

import DropdownControl from '../../components/DropdownControl.jsx';
import EditDialog from '../../components/EditDialog.jsx';
import FormInputControl from '../../components/FormInputControl.jsx';

import { isBlank } from '../../utils/string';

var RentalConditionsEditDialog = React.createClass({
  propTypes: {
    rentalCondition: React.PropTypes.object.isRequired,
    rentalConditions: React.PropTypes.object.isRequired,
    onSave: React.PropTypes.func.isRequired,
    onClose: React.PropTypes.func.isRequired,
    show: React.PropTypes.bool,
  },

  getInitialState() {
    var isNew = this.props.rentalCondition.id === 0;

    return {
      isNew: isNew,

      conditionName: this.props.rentalCondition.conditionName || '',
      comment: this.props.rentalCondition.comment || '',

      conditionNameError: '',
      commentError: '',
    };
  },

  updateState(state, callback) {
    this.setState(state, callback);
  },

  didChange() {
    if (this.state.conditionName !== this.props.rentalCondition.conditionName) { return true; }
    if (this.state.comment !== this.props.rentalCondition.comment) { return true; }

    return false;
  },

  isValid() {
    this.setState({
      conditionNameError: '',
      commentError: '',
    });

    var valid = true;

    if (isBlank(this.state.conditionName)) {
      this.setState({ conditionNameError: 'Rental condition is required' });
      valid = false;
    }

    if (this.state.conditionName === 'Non-Standard Conditions' && isBlank(this.state.comment)) {
      this.setState({ commentError: 'Comment is required for non-standard condition' });
      valid = false;
    }

    return valid;
  },

  onSave() {
    this.props.onSave({ ...this.props.rentalCondition, ...{
      conditionName: this.state.conditionName,
      comment: this.state.comment,
    }});
  },

  render() {
    // Read-only if the user cannot edit the rental agreement
    var isReadOnly = !this.props.rentalCondition.canEdit && this.props.rentalCondition.id !== 0;
    var conditions = _.sortBy(this.props.rentalConditions, 'displaySortOrder');

    return <EditDialog id="rental-conditions-edit" show={ this.props.show }
      onClose={ this.props.onClose } onSave={ this.onSave } didChange={ this.didChange } isValid={ this.isValid }
      title={
        <strong>Rental Agreement - Conditions</strong>
      }>
      <Form>
        <Grid fluid>
          <Row>
            <Col md={12}>
              <FormGroup controlId="conditionName" validationState={ this.state.conditionNameError ? 'error' : null }>
                <ControlLabel>Rate Component <sup>*</sup></ControlLabel>
                {/*TODO - use lookup list*/}
                <DropdownControl id="conditionName" disabled={ isReadOnly } title={ this.state.conditionName } updateState={ this.updateState }
                  items={ conditions } />
                <HelpBlock>{ this.state.conditionNameError }</HelpBlock>
              </FormGroup>
            </Col>
          </Row>
          <Row>
            <Col md={12}>
              <FormGroup controlId="comment">
                <ControlLabel>Comment</ControlLabel>
                <FormInputControl componentClass="textarea" defaultValue={ this.state.comment } readOnly={ isReadOnly } updateState={ this.updateState } />
              </FormGroup>
            </Col>
          </Row>
        </Grid>
      </Form>
    </EditDialog>;
  },
});

export default RentalConditionsEditDialog;

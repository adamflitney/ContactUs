import React from 'react';
import renderer from 'react-test-renderer';
import ContactUsForm from '../../components/ContactForm/ContactForm';

describe('ContactUsForm', () => {
    const page = renderer.create(<ContactUsForm />);
    it('renders correctly', () => {
        const tree = page.toJSON();
        expect(tree).toMatchSnapshot();
    });

    
})
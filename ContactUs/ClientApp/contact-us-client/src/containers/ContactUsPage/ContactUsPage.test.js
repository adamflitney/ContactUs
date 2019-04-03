import React from 'react';
import renderer from 'react-test-renderer';
import ContactUsPage from './ContactUsPage';
import ContactUsForm from '../../components/ContactForm/ContactForm';

describe('ContactUsPage', () => {
    const page = renderer.create(<ContactUsPage />);
    it('renders correctly', () => {
        const tree = page.toJSON();
        expect(tree).toMatchSnapshot();
    });

    it('contains the contact form', () => {
        const pageInstance = page.root;
        expect(pageInstance.findByType(ContactUsForm)).toBeTruthy();
    })
})
describe('Contacts-App Tests', () => {
  beforeEach(() => {
    cy.visit("http://localhost:5173"); 
  });

  it('Test for adding a contact.', () => {
    cy.get('.contacts-list li').should('have.length', 0);
  
    cy.get('input[placeholder="Ім\'я"]').type('Eugene Garbuz');
    cy.get('input[placeholder="Телефон"]').type('28623674267');
    cy.get('button').contains('Додати').click();
  
    cy.get('.contacts-list li').should('have.length', 1);
    cy.get('.contacts-list li span').first().should('have.text', 'Eugene Garbuz - 28623674267');
  });
});
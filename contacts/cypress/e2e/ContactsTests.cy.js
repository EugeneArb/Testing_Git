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

  it('Test for editing a contact.', () => {
    cy.get('input[placeholder="Ім\'я"]').type('Eugene Garbuz');
    cy.get('input[placeholder="Телефон"]').type('28623674267');
    cy.get('button').contains('Додати').click();
  
    cy.get('.contacts-list li button').contains('Редагувати').click();
    cy.get('input[placeholder="Ім\'я"]').clear().type('Genia Harbuz');
    cy.get('input[placeholder="Телефон"]').clear().type('99999999999');
    cy.get('button').contains('Редагувати').click();
  
    cy.get('.contacts-list li span').first().should('have.text', 'Genia Harbuz - 99999999999');
  });

  it('Test for deleting a contact.', () => {
    cy.get('input[placeholder="Ім\'я"]').type('Eugene Garbuz');
    cy.get('input[placeholder="Телефон"]').type('28623674267');
    cy.get('button').contains('Додати').click();
  
    cy.get('.contacts-list li button').contains('Видалити').click();
  
    cy.get('.contacts-list li').should('have.length', 0);
  });
});
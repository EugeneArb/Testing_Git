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

  it('Test for sorting contacts.', () => {
    cy.get('input[placeholder="Ім\'я"]').type('Voronaia Kira');
    cy.get('input[placeholder="Телефон"]').type('33333333333');
    cy.get('button').contains('Додати').click();
  
    cy.get('input[placeholder="Ім\'я"]').type('Saniko Karina');
    cy.get('input[placeholder="Телефон"]').type('11111111111');
    cy.get('button').contains('Додати').click();
  
    cy.get('input[placeholder="Ім\'я"]').type('Garbuz Eugene');
    cy.get('input[placeholder="Телефон"]').type('222222222222');
    cy.get('button').contains('Додати').click();

    cy.get('input[placeholder="Ім\'я"]').type('Byzivskui Artem');
    cy.get('input[placeholder="Телефон"]').type('55555555555');
    cy.get('button').contains('Додати').click();
  
    // Сортуємо за іменем
    cy.get('button').contains('Сортувати за іменем').click();
    cy.get('.contacts-list li span').eq(0).should('have.text', 'Byzivskui Artem - 55555555555');
    cy.get('.contacts-list li span').eq(1).should('have.text', 'Garbuz Eugene - 222222222222');
    cy.get('.contacts-list li span').eq(2).should('have.text', 'Saniko Karina - 11111111111');
    cy.get('.contacts-list li span').eq(3).should('have.text', 'Voronaia Kira - 33333333333');
  
    // Сортуємо за телефоном
    cy.get('button').contains('Сортувати за телефоном').click();
    cy.get('.contacts-list li span').eq(0).should('have.text', 'Saniko Karina - 11111111111');
    cy.get('.contacts-list li span').eq(1).should('have.text', 'Garbuz Eugene - 222222222222');
    cy.get('.contacts-list li span').eq(2).should('have.text', 'Voronaia Kira - 33333333333');
    cy.get('.contacts-list li span').eq(3).should('have.text', 'Byzivskui Artem - 55555555555');
  });
});
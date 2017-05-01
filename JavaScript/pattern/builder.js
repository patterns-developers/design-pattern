'use strict'

// Product
class Hamburger {
  
    set bread(bread) {
        this._bread = bread;
    }

    set main(main) {
        this._main = main;
    }

    set complement(complement) {
        this._complement = complement;
    }

    description() {
        return `${this._bread}, ${this._main}, ${this._complement}`
    }
}

// Abstract Builder

// ConcreteBuilder

// ConcreteBuilder

// Director

var hamburger = new Hamburger();
hamburger.bread = 'White Bread'
hamburger.main = 'White Bread'
hamburger.complement = 'White Bread'
console.log(hamburger.description());

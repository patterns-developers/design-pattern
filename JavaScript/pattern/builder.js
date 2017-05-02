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
class AbstractHamburgerBuilder {
    constructor() {
        this._hamburger = new Hamburger();
        if (new.target === AbstractHamburgerBuilder) {
            throw new TypeError("Cannot construct Abstract instances directly");
        }
    }
    prepareBread(){}
    prepareMain(){}
    prepareComplement(){}
}

// ConcreteBuilder
class MeatHamburgerBuilder extends AbstractHamburgerBuilder{
    prepareBread() {
        this._hamburger.bread = "hamburger bread";
    }

    prepareMain() {
        this._hamburger.main = "beef";
    }

    prepareComplement() {
        this._hamburger.complement = "cheese, mayonnaise, lettuce and tomato";
    }
}

// ConcreteBuilder
class KBarbecueHamburgerBuilder extends AbstractHamburgerBuilder{
    prepareBread() {
        this._hamburger.bread = "french bread";
    }

    prepareMain() {
        this._hamburger.main = "beef sliced";
    }

    prepareComplement() {
        this._hamburger.complement = "cheese, mayonnaise, pea, lettuce and tomato";
    }
}

// Director
class Establishment{
    set hamburgerBuilder(hamburgerBuilder) {
        this._hamburgerBuilder = hamburgerBuilder;
    }

    get hamburger() {
        return this._hamburgerBuilder._hamburger.description();
    }

    constructHamburger() {
        this._hamburgerBuilder.prepareBread();
        this._hamburgerBuilder.prepareMain();
        this._hamburgerBuilder.prepareComplement();
    }
}


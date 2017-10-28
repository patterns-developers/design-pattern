'use strict'

// Abstract Class
class AbstractFileAccess {
    constructor() {
        if (new.target === AbstractFileAccess) {
            throw new TypeError("Cannot construct AbstractFileAccess instances directly");
        }
    }
    open() { };
    read() { return "" };
    close() { };
    execute() {
        this.open();
        var msg = this.read();
        this.close();
        return msg;
    }
}

// Concrete class
class CsvAccess extends AbstractFileAccess {
    open() {
        console.log("Open file CSV");
    }

    close() {
        console.log("Close file CSV");
    }

    read() {
        return "CSV info...";
    }
}

// Concrete class
class TxtAccess extends AbstractFileAccess {
    constructor() {
        super();
    }

    open() {
        console.log("Open file Txt");
    }

    close() {
        console.log("Close file Txt");
    }

    read() {
        return "Txt info...";
    }
}
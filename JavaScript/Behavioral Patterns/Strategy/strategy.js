'use strict'

// Abstract Class
class AbstractStaff {
    constructor() {
        if (new.target === AbstractStaff) {
            throw new TypeError("Cannot construct AbstractStaff instances directly");
        }
    }
    salary(workedHours) { }
    benefits() { }
}

// Concrete class
class Developer extends AbstractStaff {
    salary(workedHours) {
        return 30 * workedHours;
    }
    benefits() {
        return 3
    }
}

class Intern extends AbstractStaff {
    salary(workedHours) {
        return 5 * workedHours;
    }
    benefits() {
        return 1
    }
}

class Manager extends AbstractStaff {
    salary(workedHours) {
        return 50 * workedHours;
    }
    benefits() {
        return 5
    }
}

// Context Class
class InfoStaff {
    constructor(staff) {
        this.staff = staff
    }

    salary(workedHours) {
        return this.staff.salary(workedHours);
    }

    benefits() {
        return this.staff.benefits();
    }
}
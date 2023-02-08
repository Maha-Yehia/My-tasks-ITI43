linkedList = {
    data: [],
    push_Val: function (val) {

        if (arguments.length != 1) {
            throw "Please send one parameter";
        }
        else if (this.data.length == 0) {
            this.data.push({ value: val });
        }
        else if (val <= this.data[this.data.length - 1].value) {
            throw "The data you entered is less than the sequence";
        }

        else {
            this.data.push({ value: val });
        }
    },

    pop_Val: function () {
        if (this.data.length === 0) {
            throw "The List is empty";
        }
        else {
            return this.data.pop();
        }
    },

    insert_Val: function (val) {
        if (arguments.length != 1) {
            throw "send one parameter";
        }
        for (var i = 0; i < this.data.length; i++) {
            if (this.data[this.data.length - 1].value < val) {
                this.data.push({ value: val });
            }

            if (this.data[i].value > val) {
                this.data.splice(i, 0, { value: val });
                break;
            }
        }

    },

    enq_Val: function (val) {
        if (arguments.length != 1) {
            throw "Send on parameter only";
        }
        else if (val < this.data[0].value) {
            this.data.unshift({ value: val });
        }
        else
            throw "Enter number less than this value";
    },

    deq_Val: function () {
        if (this.data.length === 0) {
            throw "the list is empty";
        }
        else
            this.data.shift();
    },

    Remove: function (val) {
        let flag = 0;
        if (arguments.length == 0)
            throw "enter one value";
        if (this.data.length == 0)
            throw "the list is empty";
        for (var i = 0; i < this.data.length; i++) {
            if (this.data[i].value === val)
                this.data.splice(i, 1);
            flag = 1;
        }
        if (!flag)
            throw "this value isn't found";

    },

    Display: function () {
        for (var i = 0; i < this.data.length; i++) {
            console.log(this.data[i].value);
        }
    }


};
linkedList.push_Val(4);
//linkedList.push_Val(3);
linkedList.insert_Val(2);
linkedList.insert_Val(10);
linkedList.enq_Val(1);
linkedList.deq_Val();
//linkedList.deq_Val();
//linkedList.pop_Val();

//linkedList.Remove(4);

linkedList.Display(); 
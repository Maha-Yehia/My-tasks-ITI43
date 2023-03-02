
var handler = {
    set:function(obj,prop,val){
        if(prop == "name"){
            if(typeof val == 'string' && val.length >= 7){
                obj[prop] = val;
            }else{
                throw "Name must be at least 7 characters."
            }
        }
        else if(prop == "address")
        {
            if(typeof val == "string")
            {
                obj[prop] = val
            }
            else
            {
                throw "Address must be a string"
            }
        }
        else if (prop == "age")
        {
            if(typeof val == 'number')
            {
                if (val >= 25 && val <= 60)
                    obj[prop] = val;
                else
                    throw "Age must be between 25 and 60."
            }
            else
            {
                throw "Age must be a numeric value."
            }
        }
        else
        {
            throw "Not name or address or age.";
        }
    }
}


var myProxy = new Proxy({},handler);

myProxy.name = "Mohamed";
myProxy.age = 25;
myProxy.address = "Cairo";
<h1>Prototype Design Pattern</h1>

<p>As per the GoF Definition, “Prototype Design Pattern specifies the kind of objects to create using a prototypical instance and create new objects by copying this prototype”. </p>
<p>That means it clones the existing object with its data into a new object. Any changes to the cloned object (i.e., new object) does not affect the original object.</p>
<p><strong>Note:</strong>C# provides one method i.e., <code>MemberwiseClone</code> which will create a new complete copy of the object.</p>

<br />

<h3>Shallow copy</h3>
<p>In the case of Shallow copy, a new object from the existing object will be created and then the value-type fields of the current object will be copied to the new object.</p>
<p>But in the case of reference-type, it will only copy the reference, not the referred object itself. Therefore, the original and clone refer to the same object in case of reference-type.</p>

<h3>Deep copy</h3>
<p>In the case of deep copy, it will create the new object from the existing object and then copying the fields of the current object to the newly created object.</p>
<p>If the field is a value-type, then a bit-by-bit copy of the field will be performed. If the field is a reference-type, then a new copy of the referred object is created.</p>
<p>So to say, a shallow copy on any reference-type would take place.</p>

<h3>Notes about <code>MemberwiseClone</code> in C#</h3>

*	The <code>MemberwiseClone</code> method is part of the <code>System.Object</code> class and it creates a shallow copy of the given object. 
*	<code>MemberwiseClone</code> Method only copies the non-static fields of the object into the new object.
*	In the process of copying, if a field is a value-type, a bit-by-bit copy of the field is performed. If a field is a reference-type, the reference is copied but the referenced object is not.

<br />

<h3><strong>Shallow copy implementation</strong></h3>
<p>The class of the desired object should have a method, which will return an object of the same type after executing the <code>MemberwiseClone</code> method on it, i.e., this method should be executed upon the <code>this</code> keyword.</p>
<p>Note that often casting is also applied by putting the data type name before the <code>this</code> keyword inside parenthesis.</p>    

<br />

<h3><strong>Deep copy implementation</strong></h3>
<p>In this case, if the desired object has other reference type values, first all of them should have a method for shallow cloning, which eventually would be called in cloning of the desired object.</p>
<p>But inside the method of the actual object, first a new instance should be created, upon which the <code>MemberwiseClone</code> method is called. Then, its reference values should be assigned to it using the corresponding <code>clone</code> method. 

<br />

<h3><strong>Example used in the code</strong></h3>
<p>There is a <strong>User</sstrong> object, which has a property of type <strong>Address</strong>. The shallow and deep copy operations are applied on an instance of the <strong>User</strong> class.</p>
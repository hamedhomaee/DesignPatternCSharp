<h1>Factory Design Pattern</h1>

<p>According to the Gang of Four, the Factory Design Pattern states that “A factory is an object which is used for creating other objects”.</p>
<p>In technical terms, we can say that a factory is a class with a method, which will create and return different types of objects based on the input parameter it received.</p>

<br />

<h3 style="color: rgb(80, 179, 222)"><strong>Implementation</strong></h3>

<h4 style="color: rgb(80, 179, 222)">A class should be created, mostly its name has the "Factory" suffix.</h4>

<h4 style="color: rgb(80, 179, 222)">A public static method should be added, which returns the desired data type and accepts a paramter. This paramter specifies, which object to create.</h4>

<h4 style="display: inline; color: rgb(80, 179, 222)">Mostly this method implements its logic using <code>switch</code> or <code>if</code> statements.</h4>

<br></br>

<h3 style="color: rgb(42, 135, 120)"><strong>Example</strong></h3>

<h4 style="color: rgb(42, 135, 120)">A website, in which users can register and choose their subscription type.</h4>
<h4 style="color: rgb(42, 135, 120)">According to the type the user choose, the corresponding user object would be created at runtime.</h4>

<br></br>

<h3 style="color: rgb(209, 77, 77)"><strong>Negative Point</strong></h3>
<h4 style="color: rgb(209, 77, 77)">By the emrgence of a new type of object, the editing of the Factory class would be indispensable.</h4>
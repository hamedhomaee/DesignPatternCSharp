<h1>Factory Design Pattern</h1>

<p>According to the Gang of Four, the Factory Design Pattern states that “A factory is an object which is used for creating other objects”.</p>
<p>In technical terms, we can say that a factory is a class with a method, which will create and return different types of objects based on the input parameter it received.</p>

<br />

<h3><strong>Implementation</strong></h3>

<p>A class should be created, mostly its name has the "Factory" suffix.</p>

<p>A public static method should be added, which returns the desired data type and accepts a paramter. This paramter specifies, which object to create.</p>

<p>Mostly this method implements its logic using <code>switch</code> or <code>if</code> statements.</p>

<br />

<h3><strong>Example</strong></h3>

<p>A website, in which users can register and choose their subscription type.</p>
<p>According to the type the user chooses, the corresponding user object would be created at runtime.</p>

<br />

<h3><strong>Negative Point</strong></h3>
<p>By the emrgence of a new type of object, the editing of the Factory class would be indispensable.</p>
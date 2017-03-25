/* Adición del botón de comillas angulares para español dentro
 de la barra de botones «avanzada» del nuevo editor */

if ( typeof $j != 'undefined' && typeof $j.fn.wikiEditor != 'undefined' ) {
        $j( function() {
                $j( '#wpTextbox1' ).wikiEditor( 'addToToolbar', {
                        'section': 'advanced',
                        'group': 'insert',
                        'tools': {
                                'comillas': {
                                        label: 'Comillas angulares',
                                        type: 'button',
                                        icon: 'http://upload.wikimedia.org/wikipedia/commons/0/06/Wikify-toolbutton.png',
                                        action: {
                                                type: 'encapsulate',
                                                options: {
                                                        pre: "«",
                                                        post: "»"
                                                }
                                        }
                                }
                        }
                } );
        } );
}
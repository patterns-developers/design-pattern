package org.com.designpattern.beans;

import org.junit.Test;

public class NFDPBuilderTest {

    @Test
    public void build() {
        NFBuildable builder = getBuilder(EnumNFe.NFe);
        NF result = Director.construct(builder);
        System.err.println(result);
    }

    private NFBuildable getBuilder(
        final EnumNFe type) {
        switch (type) {
            case NFe:
                return new NFCeBuilder();
            default:
                throw new IllegalStateException();
        }
    }
}

interface NFBuildable {

    Identificacao buildIdentificacao();

    Emitente buildEmitente();

    Destinatario buildDestinatario();

}

class Director {

    //builder version
    public static NF construct(
        final NFBuildable builder) {
        Identificacao identificacao = builder.buildIdentificacao();
        Emitente emitente = builder.buildEmitente();
        Destinatario destinatario = builder.buildDestinatario();
        return new NFeBuilder(identificacao, emitente, destinatario).build();
    }

    //own bean version
    public static NF _construct(
        final NFBuildable builder) {
        Identificacao identificacao = builder.buildIdentificacao();
        Emitente emitente = builder.buildEmitente();
        Destinatario destinatario = builder.buildDestinatario();
        return new NF(identificacao, emitente, destinatario);
    }
}

class NFCeBuilder
    implements
    NFBuildable {

    @Override
    public Identificacao buildIdentificacao() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public Emitente buildEmitente() {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public Destinatario buildDestinatario() {
        // TODO Auto-generated method stub
        return null;
    }
}

enum EnumNFe {
        NFe,
        NFSe,
        NFCe
}

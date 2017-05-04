package org.com.designpattern.beans;

import java.util.List;

import org.com.designpattern.builder.NFBuildable;
import org.com.designpattern.core.AbstractTemplateBuilder;
import org.junit.Test;

public class NFTest {

    @Test
    public void fluentInterface() {
        Identificacao identificacao = null;
        Emitente emitente = null;
        Destinatario destinatario = null;
        new NFBuilder()
            .withIdentificacao(identificacao)
            .withEmitente(emitente)
            .withDestinatario(destinatario);
    }
}

abstract class AnstractNFBuilder
    extends
    AbstractTemplateBuilder<NF>
    implements
    NFBuildable {

    /**
     *
     * This NF it's required three infomration:
     *
     * @param identificacao
     * @param emitente
     * @param destinatario
     */
    public AnstractNFBuilder(
        final Identificacao identificacao,
        final Emitente emitente,
        final Destinatario destinatario) {
        super(new NF());
        getBean().setIdentificacao(identificacao);
        getBean().setEmitente(emitente);
        getBean().setDestinatario(destinatario);
    }

    @Override
    public NF build() {
        return new NF(this);
    }
}

class NFeBuilder
    extends
    AnstractNFBuilder {

    public NFeBuilder(
        final Identificacao identificacao,
        final Emitente emitente,
        final Destinatario destinatario) {
        super(identificacao, emitente, destinatario);
    }
}

class NFeServicoBuilder
    extends
    AnstractNFBuilder {

    public NFeServicoBuilder(
        final Identificacao identificacao,
        final Emitente emitente,
        final Destinatario destinatario,
        final List<ImpostoServivo> iss) {
        super(identificacao, emitente, destinatario);
        getBean().setOpicional04(calculate(iss));
    }

    private Opicional calculate(
        final List<ImpostoServivo> iss) {
        // COMPLEX DEFINITION
        // ...
        throw new IllegalArgumentException();
    }
}

class NFeConsumidorBuilder
    extends
    AnstractNFBuilder {

    public NFeConsumidorBuilder(
        final Identificacao identificacao,
        final Emitente emitente,
        final Destinatario destinatario,
        final ComplexInformation complexInformation) {
        super(identificacao, emitente, destinatario);
        resolve(complexInformation);
    }

    private boolean resolve(
        final ComplexInformation complexInformation) {
        // COMPLEX DEFINITION
        // ...
        getBean().setOpicional02(null);
        getBean().setOpicional03(null);
        return true;
    }
}

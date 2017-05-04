package org.com.designpattern.beans;

import org.com.designpattern.core.AbstractTemplateBuilder;

public class NFBuilder
    extends
    AbstractTemplateBuilder<NF> {

    public NFBuilder() {
        super(new NF());
    }

    @Override
    public NF build() {
        return new NF(this);
    }

    public NFBuilder withIdentificacao(
        final Identificacao identificacao) {
        getBean().setIdentificacao(identificacao);
        return this;
    }

    public NFBuilder withEmitente(
        final Emitente emitente) {
        getBean().setEmitente(emitente);
        return this;
    }

    public NFBuilder withDestinatario(
        final Destinatario destinatario) {
        getBean().setDestinatario(destinatario);
        return this;
    }

    public NFBuilder withOpicional01(
        final Opicional opicional01) {
        getBean().setOpicional01(opicional01);
        return this;
    }

    public NFBuilder withOpicional02(
        final Opicional opicional02) {
        getBean().setOpicional02(opicional02);
        return this;
    }

    public NFBuilder withOpicional03(
        final Opicional opicional03) {
        getBean().setOpicional03(opicional03);
        return this;
    }

    public NFBuilder withOpicional04(
        final Opicional opicional04) {
        getBean().setOpicional04(opicional04);
        return this;
    }
}

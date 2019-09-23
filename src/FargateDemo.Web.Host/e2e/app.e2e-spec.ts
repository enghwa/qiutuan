import { FargateDemoTemplatePage } from './app.po';

describe('FargateDemo App', function() {
  let page: FargateDemoTemplatePage;

  beforeEach(() => {
    page = new FargateDemoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

import { IceSkoolTemplatePage } from './app.po';

describe('IceSkool App', function() {
  let page: IceSkoolTemplatePage;

  beforeEach(() => {
    page = new IceSkoolTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

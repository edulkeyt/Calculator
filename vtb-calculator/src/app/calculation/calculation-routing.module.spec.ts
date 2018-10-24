import { CalculationRoutingModule } from './calculation-routing.module';

describe('CalculationRoutingModule', () => {
  let calculationRoutingModule: CalculationRoutingModule;

  beforeEach(() => {
    calculationRoutingModule = new CalculationRoutingModule();
  });

  it('should create an instance', () => {
    expect(calculationRoutingModule).toBeTruthy();
  });
});

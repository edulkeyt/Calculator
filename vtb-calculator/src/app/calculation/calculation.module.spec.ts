import { CalculationModule } from './calculation.module';

describe('CalculationModule', () => {
  let calculationModule: CalculationModule;

  beforeEach(() => {
    calculationModule = new CalculationModule();
  });

  it('should create an instance', () => {
    expect(calculationModule).toBeTruthy();
  });
});
